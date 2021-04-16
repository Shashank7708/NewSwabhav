import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Tracing } from 'node:trace_events';
import {AppComponent1} from "./Welcome/welcome.component";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AppComponent
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

