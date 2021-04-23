import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CountrylinkService {

  constructor(private http:HttpClient) { }
private ur:string="https://restcountries.eu/rest/v2/all";
getdata():Observable<any>{
  return this.http.get<any>(this.ur);
}

}
