package com.jege.spring.boot;

import java.io.IOException;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.annotation.Bean;
import org.springframework.web.servlet.config.annotation.CorsRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurerAdapter;

import com.jege.spring.boot.datamodel.ElConfig;

/**
 * @author JE∏Á
 * @email 1272434821@qq.com
 * @description:spring boot ∆Ù∂Ø¿‡
 */

@SpringBootApplication
public class Application {

  public static void main(String[] args) throws IOException {
	  AnnotationConfigApplicationContext context = new 
			  AnnotationConfigApplicationContext(ElConfig.class);
	  ElConfig ec = context.getBean(ElConfig.class);
	  ec.outputResource();
	  context.close();
    SpringApplication.run(Application.class, args);
  }
  
//  @Bean
//  public WebMvcConfigurer corsConfigurer() {
//      return new WebMvcConfigurerAdapter() {
//          @Override
//          public void addCorsMappings(CorsRegistry registry) {
//              registry.addMapping("/**").allowedOrigins("http://localhost:3000");
//          }
//      };
//  }
}
