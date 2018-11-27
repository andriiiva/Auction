import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { FormsModule }   from '@angular/forms';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { AuctionComponent } from './auction/auction.component';
import { AddLotFormComponent } from './add-lot-form/add-lot-form.component';
import { LotListComponent } from './lot-list/lot-list.component';
import { HttpClientModule } from '@angular/common/http';

const appRoutes : Routes = [
  { path : "", component : HomeComponent },
  { path : "auction", component : AuctionComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    AuctionComponent,
    AddLotFormComponent,
    LotListComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(
      appRoutes
    ),
    FormsModule,
    HttpClientModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

