import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TableComponent } from './MyComponent/table/table.component';
import { TwoWayBindingComponent } from './MyComponent/two-way-binding/two-way-binding.component';

@NgModule({
  declarations: [
    AppComponent,
    TableComponent,
    TwoWayBindingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
