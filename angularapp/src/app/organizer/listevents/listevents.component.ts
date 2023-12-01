import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-listevents',
  templateUrl: './listevents.component.html',
  styleUrls: ['./listevents.component.css']
})
export class ListeventsComponent implements OnInit {

  constructor( private as : AdminService) { }

  eventdata: Event[] = []

  this.as.getAllEvents().subsc

  ngOnInit() {
  }

}
