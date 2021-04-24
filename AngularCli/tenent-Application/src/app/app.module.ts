import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EditComponent } from './ContactDepartment/edit/edit.component';
import { AddComponent } from './ContactDepartment/add/add.component';
import { ShowComponent } from './ContactDepartment/show/show.component';
import {HttpClientModule} from '@angular/common/http';
import { NotFoundComponentComponent } from './NotFound/not-found-component/not-found-component.component';
import {FormsModule,ReactiveFormsModule} from '@angular/forms';
import { ShowAddressComponent } from './AddressDepartment/show-address/show-address.component';
import { EditAddressComponent } from './AddressDepartment/edit-address/edit-address.component';
import { AddAddressComponent } from './AddressDepartment/add-address/add-address.component';

import { TenentRegisterComponent } from './LoginAndRegister/tenent-register/tenent-register.component';
import { UseRegisterComponent } from './LoginAndRegister/use-register/use-register.component';
import{TenentService} from './Servcices/tenent.service';
import { LoginComponent } from './LoginAndRegister/login/login.component';
import { UserListComponent } from './LoginAndRegister/user-list/user-list.component';
import { UserEditComponent } from './LoginAndRegister/user-edit/user-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    EditComponent,

    AddComponent,
    ShowComponent,
    NotFoundComponentComponent,
    ShowAddressComponent,
    EditAddressComponent,
    AddAddressComponent,
    TenentRegisterComponent,
    UseRegisterComponent,
    LoginComponent,
    UserListComponent,
    UserEditComponent,
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [TenentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
