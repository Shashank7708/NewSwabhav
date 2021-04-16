import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BindingComponent } from './MyComponent/binding/binding.component';
import {FormsModule} from "@angular/forms";
import { FormValidationComponent } from './MyComponent/form-validation/form-validation.component';
@NgModule({
  declarations: [
    AppComponent,
    BindingComponent,
    FormValidationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
