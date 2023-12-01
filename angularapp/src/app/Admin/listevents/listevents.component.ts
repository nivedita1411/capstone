import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-listevents',
  templateUrl: './listevents.component.html',
  styleUrls: ['./listevents.component.css']
})
export class ListeventsComponent implements OnInit {

  eventdata: Event[] = []

  constructor( private as : AdminService) {
    this.as.getAllEvents().subscribe(data => {this.eventdata.push(...data)})
    console.log(this.eventdata)
   }
  
  ngOnInit() {
  }

}
