import { Injectable } from '@angular/core';
import { IMovie } from '../model/imovie';
import {HttpClient , HttpHeaders} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Idetails } from '../model/idetail';

@Injectable({
  providedIn: 'root'
})
export class MovieserviceService {

  private url = "https://8080-bacdcffabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Movie"
  private url2 = "https://8080-bacdcffabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Detail"
  // id:number

  constructor( private  httpclient:HttpClient) { }

  getAllMovies():Observable <any[]>
  {
    return this.httpclient.get<any[]>(this.url + '/listmovies')
  }

  getMovie(id:number):Observable<IMovie>
  {
    return this.httpclient.get<IMovie>(this.url + '/listmovies/' + id)
  }

  httpOptions = {headers:new HttpHeaders({'Content-type':'application/json'})}
  addMovie(moviedata:IMovie):Observable<IMovie>{
    return this.httpclient.post<IMovie>(this.url+'/AddMovie',moviedata,this.httpOptions)
  }

  editMovie(moviedata:IMovie):Observable<IMovie>
  {
    return this.httpclient.put<IMovie>(this.url + '/EditMovie/'+ moviedata.id,moviedata,this.httpOptions)
  }
  deleteMovie(id:number):Observable<IMovie>
  {
    return this.httpclient.delete<IMovie>(this.url + '/DeleteMovie/' + id) 
  }

  addDetails(detailsdata: Idetails) :Observable<Idetails>{
    return this.httpclient.post<Idetails>(this.url2 + '/AddMovieDetails',detailsdata, this.httpOptions)
  }
}

