import { Component, OnInit } from '@angular/core';
import { StudentserviceService } from 'src/app/studentservice.service';

@Component({
  selector: 'app-show-student',
  templateUrl: './show-student.component.html',
  styleUrls: ['./show-student.component.scss']
})
export class ShowStudentComponent implements OnInit {

  constructor(private service:StudentserviceService) { }
public students:any[]=[];
  ngOnInit(): void {
    this.service.getdata().subscribe(data=>{console.log(data),this.students=data});
  }

}
