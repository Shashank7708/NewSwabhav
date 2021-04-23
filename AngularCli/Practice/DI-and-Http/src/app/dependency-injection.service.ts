import { Injectable } from '@angular/core';
import { empty } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DependencyInjectionService {

getEmployee(){
  return [
     {"id":1,"name":"Andrew","age":30},
     {"id":2,"name":"Brandon","age":20},
     {"id":3,"name":"Romy","age":40},
     {"id":4,"name":"Vishal","age":39}
   ];
   
}


  constructor() { }
}
