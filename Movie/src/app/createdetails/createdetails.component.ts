import { Component, OnInit } from '@angular/core';
import { IDetail } from '../model/idetail';

@Component({
  selector: 'app-createdetails',
  templateUrl: './createdetails.component.html',
  styleUrls: ['./createdetails.component.css']
})
export class CreatedetailsComponent implements OnInit {
  detailsdata: IDetail = {}

  constructor() { }

  ngOnInit() {
  }

}
