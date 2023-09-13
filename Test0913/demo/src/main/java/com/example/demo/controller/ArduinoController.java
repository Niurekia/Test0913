package com.example.demo.controller;

import lombok.extern.slf4j.Slf4j;
import org.springframework.context.annotation.Configuration;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Configuration
@Slf4j
@RequestMapping("/arduino")
public class ArduinoController {

    @GetMapping("/index")
    public void index() {
        log.info("GET /arduino/index");
    }
}

