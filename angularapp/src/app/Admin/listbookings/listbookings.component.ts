import { Component, OnInit } from '@angular/core';
import { Payment } from 'src/app/models/payment';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-listbookings',
  templateUrl: './listbookings.component.html',
  styleUrls: ['./listbookings.component.css']
})
export class ListbookingsComponent implements OnInit {

  paymentdata: Payment[]=[]

  constructor(private as:AdminService) {
    this.as.getAllBookings().subscribe(data => {this.paymentdata.push(...data)})
    console.log(this.paymentdata)
   }

  ngOnInit() {
  }

}
