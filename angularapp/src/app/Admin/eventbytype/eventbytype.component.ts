import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-eventbytype',
  templateUrl: './eventbytype.component.html',
  styleUrls: ['./eventbytype.component.css']
})
export class EventbytypeComponent implements OnInit {

  searchByTypeForm: FormGroup;
  eventList: any[] = [];
  eventTypes: string[] = ['conference', 'inductionProgram', 'productLaunch', 'tradeShow', 'appreciationCeremony', 'teamBuildingActivity'];

  constructor(private as : AdminService, private fb : FormBuilder, private router: Router) { 
    this.searchByTypeForm = this.fb.group({
      eventType: ['']
    });
  }

  redirectToEditEvent(){
    this.router.navigate(['/editevent/:id'])
  }

  redirectToDeleteEvent(){
    this.router.navigate(['/deleteevent/:id'])
  }
  
  onSubmit() {
    const selectedEventType = this.searchByTypeForm.value.eventType;
    this.as.getEventByType(selectedEventType).subscribe(
      (data: any[]) => {
        this.eventList = data;
        console.log(this.eventList)
      },
      (error) => {
        console.error('Error fetching events:', error);
        // Handle error as needed
      }
    );
  }

  ngOnInit() {
  }

}
