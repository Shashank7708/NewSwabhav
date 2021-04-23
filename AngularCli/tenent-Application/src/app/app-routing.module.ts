import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {AddComponent} from './ContactDepartment/add/add.component';
import{ShowComponent} from "./ContactDepartment/show/show.component";
import {NotFoundComponentComponent} from "./NotFound/not-found-component/not-found-component.component";
import {EditComponent} from './ContactDepartment/edit/edit.component';
import {ShowAddressComponent} from './AddressDepartment/show-address/show-address.component';
import {EditAddressComponent} from './AddressDepartment/edit-address/edit-address.component';
import {AddAddressComponent} from './AddressDepartment/add-address/add-address.component';
 const routes: Routes = [
  {path:"",redirectTo:"/home",pathMatch:"full"},
 
  {path:"home",component:ShowComponent},
  {path:"add-contact",component:AddComponent},
  {path:"edit-contact/:id",component:EditComponent},
  {path:":id/show-address",component:ShowAddressComponent},
  {path:"contact/:id/add-address",component:AddAddressComponent},
  {path:"contact/:id/edit-address/:id1",component:EditAddressComponent},

 // {path:"**",component:NotFoundComponentComponent}
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
