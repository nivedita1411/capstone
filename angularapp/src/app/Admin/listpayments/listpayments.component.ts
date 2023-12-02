import { Component, OnInit } from '@angular/core';
import { Payment } from 'src/app/models/payment';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-listpayments',
  templateUrl: './listpayments.component.html',
  styleUrls: ['./listpayments.component.css']
})
export class ListpaymentsComponent implements OnInit {

  paymentdata: Payment[] = []

  constructor(private as: AdminService) { 
    this.as.getAllPayments().subscribe(data => {this.paymentdata.push(...data)})
    console.log(this.paymentdata)
  }

  ngOnInit() {
  }

}
