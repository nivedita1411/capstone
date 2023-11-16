import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListmovieComponent } from './listmovie/listmovie.component';
import { FindmovieComponent } from './findmovie/findmovie.component';

@NgModule({
  declarations: [
    AppComponent,
    ListmovieComponent,
    FindmovieComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
