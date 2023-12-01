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
  AddEvent(eventdata : Event) : Observable<any>
  {
    return this.httpclient.post<any>(this.apiUrl + '/event',eventdata, this.httpOptions)
  }

  EditEvent(eventdata : Event) : Observable<any>
  {
    return this.httpclient.put(this.apiUrl + '/admin/updateevent' + eventdata.id, eventdata,this.httpOptions)
  }

  DeleteEvent(id : number) : Observable<any>
  {
    return this.httpclient.delete<any>(this.apiUrl + '/deleteevent' + id )
  }

  updateStatus(id1:number, id2:number, eventdata: Event) : Observable<any>
  {
    return this.httpclient.put<any>(this.apiUrl + '/admin/booking/changestatus/' + id1 + '/' + id2,eventdata, this.httpOptions )
  }
  getEventByType(eventtype : string) : Observable <any[]>
  {
    return this.httpclient.get<any[]>(this.apiUrl + '/admin/event/' + eventtype)
  }
}
