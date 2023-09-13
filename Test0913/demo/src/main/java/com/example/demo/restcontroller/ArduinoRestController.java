package com.example.demo.restcontroller;

import com.fazecast.jSerialComm.SerialPort;
import lombok.extern.slf4j.Slf4j;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.io.*;

@RestController
@Slf4j
@RequestMapping("/arduino")
public class ArduinoRestController {

    private SerialPort serialPort;
    private OutputStream outputStream;
    private InputStream inputStream;

    private String LedLog;
    private String TmpLog;
    private String LightLog;
    private String DistanceLog;

    @GetMapping("/connection/{COM}")
    public ResponseEntity<String> setConnection(@PathVariable("COM") String COM) {

        log.info("GET /arduino/connection " + COM);

        if (serialPort != null) {
            serialPort.closePort();
            serialPort = null;
        }


        //Port Setting
        serialPort = SerialPort.getCommPort(COM);

        //Connection Setting
        serialPort.setBaudRate(9600);
        serialPort.setNumDataBits(8);
        serialPort.setNumStopBits(0);
        serialPort.setParity(0);
        serialPort.setComPortTimeouts(SerialPort.TIMEOUT_READ_BLOCKING, 2000, 0);

        boolean isOpen = serialPort.openPort();
        log.info(("isOpen ? " + isOpen));

        if (isOpen) {
            this.outputStream = serialPort.getOutputStream();
            this.inputStream = serialPort.getInputStream();

            //----------------------------------------------------------------
            //수신 스레드 동작
            //----------------------------------------------------------------

            Worker worker = new Worker();
            Thread th = new Thread(worker);
            th.start();

            return new ResponseEntity("Connection Success", HttpStatus.OK);
        } else {
            return new ResponseEntity("Connection Success", HttpStatus.BAD_GATEWAY);
        }


    }

    @GetMapping("/led/{value}")
    public void led_Controller(@PathVariable String value) throws IOException {
        log.info("GET /arduino/led/value: " + value);
        if (serialPort.isOpen()) {
            outputStream.write(value.getBytes());
        }
    }

    @GetMapping("/message/led")
    public String led_Message() {
        return LedLog;
    }

    @GetMapping("/message/tmp")
    public String tmp_Message() {
        return TmpLog;
    }

    @GetMapping("/message/light")
    public String light_Message() {
        return LightLog;
    }

    @GetMapping("/message/distance")
    public String distance_Message() {
        return DistanceLog;
    }

//----------------------------------------------------------------
//수신 스레드 클래스
//----------------------------------------------------------------

    class Worker implements Runnable {

        DataInputStream din;
        byte[] buffer = new byte[4096];

        @Override
        public void run() {

            din = new DataInputStream(inputStream);

            try {
                while (!Thread.interrupted()) {
                    if (din != null) {
                        String data = din.readLine();
                        System.out.println("[Data]: " + data);
                        String[] arr = data.split("~");
                        try {
                            if (arr.length > 3) {
                                LedLog = arr[0];
                                TmpLog = arr[1];
                                LightLog = arr[2];
                                DistanceLog = arr[3];
                            } else {
                                TmpLog = arr[0];
                                LightLog = arr[1];
                                DistanceLog = arr[2];
                            }
//
                        } catch (ArrayIndexOutOfBoundsException el) {
                            el.printStackTrace();
                            ;
                        }

                    }
                    Thread.sleep(200);

                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

    }
}
