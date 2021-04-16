import { Component, Input, OnInit } from '@angular/core';
import { Todo } from "src/app/Todo"


@Component({
  selector: 'app-todos-item',
  templateUrl: './todos-item.component.html',
  styleUrls: ['./todos-item.component.css']
})
export class TodosItemComponent implements OnInit {
@Input() todo:Todo;
  constructor() { }

  ngOnInit(): void {
  }

}
