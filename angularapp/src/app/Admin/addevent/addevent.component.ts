import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-addevent',
  templateUrl: './addevent.component.html',
  styleUrls: ['./addevent.component.css']
})
export class AddeventComponent implements OnInit {

  constructor(private as:AdminService, private fb : FormBuilder, private router: Router) { }

  eventdata: any

  eventdataForm = this.fb.group({
    eventType: [''],
    eventDescription: [''],
    participantsCount: [''],
    eventCharges: ['']
  })

  onSubmit(){
    this.eventdata = this.eventdataForm.value
    console.log(this.eventdata)
    this.as.AddEvent(this.eventdata).subscribe(
      ()=>{
        this.router.navigate(['/event'])
        alert("Event Added")
      }
    )
  }

  ngOnInit() {
  }

}
