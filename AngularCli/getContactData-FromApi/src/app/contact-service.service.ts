import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Icontact} from './IContact';
@Injectable({
  providedIn: 'root'
})
export class ContactServiceService {
private _url:string="http://localhost:57364/api/contact";
  constructor(private http:HttpClient) { }

getEmployee():Observable<Icontact[]>{
  return this.http.get<Icontact[]>(this._url);
}



}
