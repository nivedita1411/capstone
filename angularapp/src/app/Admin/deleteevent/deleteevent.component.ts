// import { Component, OnInit } from '@angular/core';
// import { ActivatedRoute, Router } from '@angular/router';
// import { Event } from 'src/app/models/event';
// import { AdminService } from 'src/app/services/admin.service';

// @Component({
//   selector: 'app-deleteevent',
//   templateUrl: './deleteevent.component.html',
//   styleUrls: ['./deleteevent.component.css']
// })
// export class DeleteeventComponent implements OnInit {

//   constructor(private as:AdminService, private ar: ActivatedRoute, private route: Router) { }

//   isDelete:boolean

//   eventdata : Event = 
//   { id:0,
//     eventType:'',
//     eventDescription:'',
//     participantsCount:0,
//     eventCharges:0,
//     isDelete:true
//   }
//   id:number
  
//   ngOnInit() {
//     const tid = this.ar.snapshot.paramMap.get('id')
//     this.id = Number(tid)
//     this.getEventById(this.id)
//   }

//   // deleteEvent(): void {
//   //   this.as.DeleteEvent(this.eventdata,this.id).subscribe(() => {
//   //     this.isDelete = false;
//   //      // Set isDelete to true after successful update
//   //      this.route.navigate(['Admin/event'])
//   //   });
//   // }

//   deleteEvent(): void {
//     this.eventdata.isDelete = false; // Update isDelete locally
//     this.as.DeleteEvent( this.eventdata, this.id).subscribe(() => {
//       this.route.navigate(['Admin/event']);
//     });
//   }

//   getEventById(id: number) {
//     this.as.getEventById(id).subscribe((data: Event) => {
//       this.eventdata = data;
//     });
//   }

//   // onSubmit(event : Event) : void {
//   //   this.eventdata = event
//   //   this.as.DeleteEvent(this.id).subscribe(() => {
//   //     alert("Record Deleted")
//   //     this.route.navigate(['Admin/event'])
//   //   })
//   // }

//   showAlert(): void {
//     // Code to show the alert goes here
//     // After clicking on "Ok" button, call deleteBooking() method
//     if (confirm("Are you sure you want to delete the booking?")) {
//       this.deleteEvent();
//     }
//   }

// }

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

  constructor(private as: AdminService, private ar: ActivatedRoute, private route: Router) { }

  isDelete: boolean;
  eventdata: Event = {
    id: 0,
    eventType: '',
    eventDescription: '',
    participantsCount: 0,
    eventCharges: 0,
    isDelete: true
  };
  id: number;
  
  ngOnInit() {
    const tid = this.ar.snapshot.paramMap.get('id');
    this.id = Number(tid);
    this.getEventById(this.id);
  }

  deleteEvent(): void {
    this.eventdata.isDelete = false; // Update isDelete locally
    this.as.DeleteEvent(this.id).subscribe(() => {
      this.route.navigate(['Admin/event']);
    });
  }

  getEventById(id: number) {
    this.as.getEventById(id).subscribe((data: Event) => {
      this.eventdata = data;
    });
  }

  showAlert(): void {
    if (confirm("Are you sure you want to delete the booking?")) {
      this.deleteEvent();
    }
  }
}


