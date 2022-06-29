import { Component, OnInit } from '@angular/core';
import { NgModule } from '@angular/core';

import { Student } from './models/student';
import { RestApiService } from './app.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  students: Student[] = [];
  constructor(public restApi: RestApiService, public router: Router) {}
  ngOnInit(): void {
    this.getStudents();
  }

  getStudents() {
    this.students = [];
    this.restApi.getStudents().pipe().subscribe(x => this.students.push(x));
  }
}
