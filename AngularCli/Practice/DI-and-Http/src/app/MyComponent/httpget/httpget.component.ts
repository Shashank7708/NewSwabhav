import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-httpget',
  templateUrl: './httpget.component.html',
  styleUrls: ['./httpget.component.scss']
})
export class HttpgetComponent implements OnInit {

  constructor(private http:HttpClient) {
console.log("in constructor");
   }
 numbr:number=0;
facts:string[]=[];
  ngOnInit(): void {
this.facts=[]
  }
  getFact(){
    this.http.get("http://numbersapi.com/"+this.numbr).subscribe(data=>{
      console.log(data)
      this.facts.unshift(data.toString())
    })
    
  }

}
