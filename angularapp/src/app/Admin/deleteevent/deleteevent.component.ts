import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Event } from 'src/app/models/event';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-deleteevent',
  templateUrl: './deleteevent.component.html',
  styleUrls: ['./deleteevent.component.css']
})
export class DeleteeventComponent implements OnInit {

  constructor(private as:AdminService, private ar: ActivatedRoute, private route: Router) { }

  eventdata : Event = 
  { id:0,
    eventType:'',
    eventDescription:'',
    participantsCount:0,
    eventCharges:0
  }
  id:number
  
  ngOnInit() {
    const tid = this.ar.snapshot.paramMap.get('id')
    this.id = Number(tid)
    this.getEventById(this.id)
  }

  getEventById(id:number)
  {
    this.as.getEventById(id).subscribe((data:Event) => this.eventdata = data)
  }

  onSubmit(event : Event) : void {
    this.eventdata = event
    this.as.DeleteEvent(this.id).subscribe(() => {
      alert("Record Deleted")
      this.route.navigate(['Admin/event'])
    })
  }

}
