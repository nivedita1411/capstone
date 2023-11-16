import { Component, OnInit } from '@angular/core';
import { MovieserviceService } from '../services/movieservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IMovie } from '../model/imovie';

@Component({
  selector: 'app-editmovie',
  templateUrl: './editmovie.component.html',
  styleUrls: ['./editmovie.component.css']
})
export class EditmovieComponent implements OnInit {

  constructor(private ms:MovieserviceService, private route:Router,private ar: ActivatedRoute) { }
  moviedata: IMovie = {id:0,name:'',releaseYear:0,rating:0}
  id:number

  ngOnInit() {
    const tid = this.ar.snapshot.paramMap.get('id')
    this.id = Number(tid)
    this.getMovie(this.id)
  }

  getMovie(id:number)
  {
    this.ms.getMovie(id).subscribe((data:IMovie) => this.moviedata = data)
  }

  saveData(movie:IMovie)
  {
    this.moviedata = movie
    this.ms.editMovie(this.moviedata).subscribe(() => {
      alert("Record Edited")
      this.route.navigate(['/listmovies'])
    })
  }

}
