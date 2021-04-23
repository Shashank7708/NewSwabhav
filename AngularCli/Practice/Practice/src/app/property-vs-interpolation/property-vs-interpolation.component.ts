import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-property-vs-interpolation',
  templateUrl: './property-vs-interpolation.component.html',
  styleUrls: ['./property-vs-interpolation.component.scss']
})
export class PropertyVsInterpolationComponent implements OnInit {

  constructor() { }
public myId=13;
public value="Vishwas";
  ngOnInit(): void {
  }

}
