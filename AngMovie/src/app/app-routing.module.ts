import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListMovieComponent } from './list-movie/list-movie.component';
import { FindmovieComponent } from './findmovie/findmovie.component';


const routes: Routes = [
  {path : 'listmovies',component:ListMovieComponent},
  {path : 'find/id', component:FindmovieComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
