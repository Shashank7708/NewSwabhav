import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {DependencyInjectionService} from './dependency-injection.service'
import {HttpClientModule} from '@angular/common/http';
import { HttpClient1Component } from './MyComponent/http-client1/http-client1.component'
import {HttpserviceService} from './MyComponent/httpservice.service';
import { HttpgetComponent } from './MyComponent/httpget/httpget.component';
@NgModule({
  declarations: [
    AppComponent,
    HttpClient1Component,
    HttpgetComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [DependencyInjectionService,
  HttpserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
