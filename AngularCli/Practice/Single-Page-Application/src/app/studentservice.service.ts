import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentserviceService {

  constructor(public http:HttpClient) { }
public _url:string="http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/";


private ur:string="https://restcountries.eu/rest/v2/all";
getdata():Observable<any>{
  return this.http.get<any>(this._url);
}

}
