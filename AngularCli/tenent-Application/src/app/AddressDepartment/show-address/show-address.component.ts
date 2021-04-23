import { state } from '@angular/animations';
import { ConvertActionBindingResult } from '@angular/compiler/src/compiler_util/expression_converter';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { ContactServiceService } from 'src/app/contact-service.service';
import { Address } from '../address';

@Component({
  selector: 'show-address',
  templateUrl: './show-address.component.html',
  styleUrls: ['./show-address.component.scss']
})
export class ShowAddressComponent implements OnInit {
  public addresses:Address[]=[];
  constructor(private service:ContactServiceService,private route:Router,private _router:ActivatedRoute) { }
 
  getdata(){
    this.service.getaddress(this.contactid).subscribe(data=>{ 
      console.log(this.contactid);
      this.addresses=data});
  }
  contactid:any;
  ngOnInit(): void {
  //this.userid=history.state;
  this._router.paramMap.subscribe((param:ParamMap)=>{
    this.contactid = param.get('id');
    this.getdata();
  })
  }
  editClick(address:Address){
    this.route.navigateByUrl("contact/"+this.contactid+"/edit-address/"+address.id,{state:address})
  }
  deleteClick(addressid:any){
    this.service.deleteaddress(this.contactid,addressid).
                 subscribe(data=>{console.log(data),this.getdata()});
this.getdata();
  }
  addClick(){
    this.route.navigateByUrl("contact/"+this.contactid+"/add-address");
  }

}
