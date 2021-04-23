import { Component, Input, OnInit, Output } from '@angular/core';

import {EventEmitter} from '@angular/core';
@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.scss']
})
export class ChildComponent implements OnInit {

  
  @Input() public rating:any;
  @Output() ratingEvent:EventEmitter<number>
  @Input() public ParentData:any;
  ngOnInit(): void {
  }
  @Output() public ChildEvent=new EventEmitter();
  fireEvent(){
this.ChildEvent.emit("Hey Parent I Am Child Event");
  }

  constructor(){ 
    this.ratingEvent=new EventEmitter<number>();
    this.ratingEvent.emit(this.rating);
  }

  onHover($event:any){

  }
}
