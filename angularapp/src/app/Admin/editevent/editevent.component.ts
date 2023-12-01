import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-editevent',
  templateUrl: './editevent.component.html',
  styleUrls: ['./editevent.component.css']
})
export class EditeventComponent implements OnInit {

  editeventdata : any
  id:number
  constructor(private as:AdminService, private route : Router, private fb : FormBuilder, private ar: ActivatedRoute) { 
  }

  editeventdataForm = this.fb.group({
    eventType: [''],
    eventDescription: [''],
    participantsCount: [''],
    eventCharges: ['']
  })

  onSubmit(){
    this.editeventdata = this.editeventdataForm.value
    console.log(this.editeventdata)
    this.as.EditEvent(this.editeventdata).subscribe(
      ()=>{
        alert("Event Edited Successfully")
      }
    )
    
  }

  getEventById(id:number)
  {
    this.as.getEventById(id).subscribe((data:Event) => this.editeventdata = data)
  }

  ngOnInit() {
    const tid = this.ar.snapshot.paramMap.get('id')
    this.id = Number(tid)
    this.getEventById(this.id)
  }

}
