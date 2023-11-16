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
  }

}
