import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor() { }

  ngOnInit(): void {
  }
  starNumber !: any;
  ratingHandler(event:any){
    this.starNumber = event;
  }
}
