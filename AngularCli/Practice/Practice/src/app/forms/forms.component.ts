import { Component, OnInit } from '@angular/core';
import {FormsModule} from '@angular/forms'
@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.scss']
})
export class FormsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  public firstname:any;
  public lastname:any;
  

}
