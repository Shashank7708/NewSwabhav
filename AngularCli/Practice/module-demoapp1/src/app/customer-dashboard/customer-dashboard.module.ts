import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {CustomerComponentComponent} from '../CustomerDashboard/customer-component/customer-component.component'


@NgModule({
  declarations: [
  CustomerComponentComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    CustomerComponentComponent
  ]

})
export class CustomerDashboardModule { }
