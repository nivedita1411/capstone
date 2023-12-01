import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  private apiUrl : ""

  constructor(private httpclient : HttpClient) { }

  getAllEvents() : Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.apiUrl + '/event')
  }

  getAllBookings() : Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.apiUrl + '/admin/ListBookings' )
  }

  getAllPayments() : Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.apiUrl + '/ListPayments')
  }

  httpOptions = {headers: new HttpHeaders({'Content-type':'application/json'})}
  AddEvent()
}
