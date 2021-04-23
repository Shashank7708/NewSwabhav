import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AboutComponent} from "./MyComponent/about/about.component";
import {HomeComponent} from "./MyComponent/home/home.component"
import {CareerComponent} from "./MyComponent/career/career.component"
import {NotfoundComponent} from "./MyComponent/notfound/notfound.component"
import {ShowStudentComponent} from "./MyComponent/show-student/show-student.component"


const routes: Routes = [
  {path:"emp",component:HomeComponent},
  {path:"about",component:AboutComponent},
  {path:"career",component:CareerComponent},
  {path:"",redirectTo:"/home",pathMatch:"full"},
  
  {path:"students",component:ShowStudentComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
