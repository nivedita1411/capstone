import { Component, OnInit } from '@angular/core';
import { MovieService } from '../MovieService/movie.service';
import { IMovie } from '../model/imovie';

@Component({
  selector: 'app-list-movie',
  templateUrl: './list-movie.component.html',
  styleUrls: ['./list-movie.component.css']
})
export class ListMovieComponent implements OnInit {
  moviedata: IMovie[] = []

  constructor(private movieservice: MovieService) {
    this.movieservice.getAllMovies().subscribe()
   }

  ngOnInit() {
  }

}
