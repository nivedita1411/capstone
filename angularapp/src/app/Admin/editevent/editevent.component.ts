import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Event } from 'src/app/models/event';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-editevent',
  templateUrl: './editevent.component.html',
  styleUrls: ['./editevent.component.css']
})
export class EditeventComponent implements OnInit {

  
  constructor(private as:AdminService, private route : Router, private fb : FormBuilder, private ar: ActivatedRoute) { 
  }  

  editeventdata : Event = 
  { id:0,
    eventType:'',
    eventDescription:'',
    participantsCount:0,
    eventCharges:0,
    isDelete:false
  }
  id:number

  ngOnInit() {
    const tid = this.ar.snapshot.paramMap.get('id')
    this.id = Number(tid)
    this.getEventById(this.id)
  }

  getEventById(id:number)
  {
    this.as.getEventById(id).subscribe((data:Event) => this.editeventdata = data)
  }

  onSubmit(event : Event)
  {
    this.editeventdata = event
    this.as.EditEvent(this.editeventdata, this.id).subscribe(()=>
    {
      alert("Event Edited Successfully")
      this.route.navigate(['Admin/event'])
    })
  }

}
