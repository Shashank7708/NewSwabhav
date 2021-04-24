import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {AddComponent} from './ContactDepartment/add/add.component';
import{ShowComponent} from "./ContactDepartment/show/show.component";
import {EditComponent} from './ContactDepartment/edit/edit.component';
import {ShowAddressComponent} from './AddressDepartment/show-address/show-address.component';
import {EditAddressComponent} from './AddressDepartment/edit-address/edit-address.component';
import {AddAddressComponent} from './AddressDepartment/add-address/add-address.component';
import{UseRegisterComponent} from "./LoginAndRegister/use-register/use-register.component"
import {TenentRegisterComponent} from './LoginAndRegister/tenent-register/tenent-register.component';
import { LoginComponent } from './LoginAndRegister/login/login.component';
import { UserListComponent } from './LoginAndRegister/user-list/user-list.component';
import {UserEditComponent} from './LoginAndRegister/user-edit/user-edit.component';

 const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  {path:'home',component:LoginComponent},
  {path:"tenent/user-list",component:UserListComponent},
  {path:"tenent/user/show-contact",component:ShowComponent},
  {path:"tenent/user-register",component:UseRegisterComponent},
  {path:"tenent/user/edit",component:UserEditComponent},
  {path:"tenent/user/contact/edit",component:EditComponent},
  {path:"tenent/user/add-contact",component:AddComponent},
  {path:"tenent/user/contatc/address",component:ShowAddressComponent},
  {path:"tenent/user/contact/add-address",component:AddAddressComponent},
  {path:"tenent/user/contact/edit-address",component:EditAddressComponent},
  
 // {path:"**",component:NotFoundComponentComponent}
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
