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
    const tid = this.ar.snapshot.paramMap.get('id')
    this.id = Number(tid)
    this.getPlayer(this.id)
  }

  ngOnInit() {
  }

}
