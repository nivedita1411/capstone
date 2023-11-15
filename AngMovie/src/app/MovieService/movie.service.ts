import { Injectable } from '@angular/core';
import { IMovie } from '../model/imovie';
import {HttpClient , HttpHeaders} from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private url = "https://8080-bacdcffabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Movie"
  constructor(private httpclient:HttpClient) { }

  getAllMovies():Observable<IMovie[]>{
    return this.httpclient.get<IMovie[]>(`${this.url}/listmovies`)
  }

  movie:IMovie
  getMovie(id:number) : Observable<IMovie> {
    return this.httpclient.get<IMovie>(this.url + '/ListMovies/' + id)
  }
}
