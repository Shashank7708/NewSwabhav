import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './MyComponent/home/home.component';
import { AboutComponent } from './MyComponent/about/about.component';
import { CareerComponent } from './MyComponent/career/career.component';
import { NotfoundComponent } from './MyComponent/notfound/notfound.component';
import { ShowStudentComponent } from './MyComponent/show-student/show-student.component';
import {HttpClientModule} from '@angular/common/http';
import {StudentserviceService} from "./studentservice.service"
@NgModule({

  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    CareerComponent,
    NotfoundComponent,
    ShowStudentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [StudentserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
