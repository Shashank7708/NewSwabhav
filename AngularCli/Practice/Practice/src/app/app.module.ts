import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PropertyVsInterpolationComponent } from './property-vs-interpolation/property-vs-interpolation.component';
import { UsingNgModelComponent } from './using-ng-model/using-ng-model.component';
import {FormsModule} from '@angular/forms';
import { FormsComponent } from './forms/forms.component';
import {HttpClientModule} from '@angular/common/http'
import {ReactiveFormsModule} from '@angular/forms';
import { CountryDataComponent } from './country-data/country-data.component';
import {CountrylinkService} from './countrylink.service'


@NgModule({

  declarations: [
    AppComponent,
    PropertyVsInterpolationComponent,
    UsingNgModelComponent,
    FormsComponent,
    CountryDataComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
  ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [CountrylinkService],
  bootstrap: [AppComponent]
})
export class AppModule { }
