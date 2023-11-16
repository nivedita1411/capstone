import { Component, OnInit } from '@angular/core';
import { MovieserviceService } from '../services/movieservice.service';
import { IMovie } from '../model/imovie';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.css']
})
export class AddMovieComponent implements OnInit {
  moviedata: IMovie = {id:0,name:'',releaseYear:0,rating:0}

  constructor(private ms: MovieserviceService, private route:Router) { }

  saveData(movie:IMovie):void{
    this.moviedata = movie
    this.ms.addMovie(this.moviedata).subscribe(
      ()=>{
        alert('Record Added Successfully')
        this.route.navigate(['/listmovies'])
        
      }
    )

  }

  ngOnInit() {
  }

}
