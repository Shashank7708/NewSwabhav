import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import {IEmployee} from './employee';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpserviceService {

  constructor(private http:HttpClient) {

   }
private url:string="http://localhost:57364/api/contact";
getEmployee():Observable<IEmployee[]>{
  return this.http.get<IEmployee[]>(this.url);
}





}
