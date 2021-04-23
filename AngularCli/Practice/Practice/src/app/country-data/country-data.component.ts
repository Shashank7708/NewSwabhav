import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CountrylinkService } from '../countrylink.service';

@Component({
  selector: 'app-country-data',
  templateUrl: './country-data.component.html',
  styleUrls: ['./country-data.component.scss']
})
export class CountryDataComponent implements OnInit {

  constructor(private http:CountrylinkService) { }
public _url:string="https://restcountries.eu/rest/v2/all";

public counrty:any[]=[];
  ngOnInit(): void {
    this.http.getdata().subscribe(data=>{this.counrty=data});

  }


}
