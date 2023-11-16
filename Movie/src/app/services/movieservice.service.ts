import { Injectable } from '@angular/core';
import { IMovie } from '../model/imovie';
import {HttpClient , HttpHeaders} from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MovieserviceService {

  private url = "https://8080-bacdcffabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Movie"
  // id:number

  constructor( private  httpclient:HttpClient) { }

  getAllMovies():Observable <any[]>
  {
    return this.httpclient.get<any[]>(this.url + '/ListMovies')
  }

  getMovie(id:number):Observable<IMovie>
  {
    return this.httpclient.get<IMovie>(this.url + '/ListMovies/' + id)
  }
}
