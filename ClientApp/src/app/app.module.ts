import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { FormsModule }   from '@angular/forms';
import { AppComponent } from './app.component';
import { HeaderComponent } from './layout/header/header.component';
import { HomeComponent } from './pages/home/home.component';
import { AuctionComponent } from './pages/auction/auction.component';
import { HttpClientModule } from '@angular/common/http';
import { LotListComponent } from './pages/auction/lot-list/lot-list.component';
import { LotPageComponent } from './pages/auction/lot-page/lot-page.component';
import { AddLotFormComponent } from './pages/auction/add-lot-form/add-lot-form.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { FooterComponent } from './layout/footer/footer.component';
import { ExtraContentComponent } from './layout/extra-content/extra-content.component';

const appRoutes : Routes = [
  { path : "", component : HomeComponent },
  { path : "auction", component : AuctionComponent },
  { path : "auction/lot/:id", component : LotPageComponent }
  // { path : "", component : AuctionComponent, data: {hideSidebar: true} },
  // { path : "", component : AuctionComponent },
  // { path : "auction/lot/:id", component : LotPageComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    AuctionComponent,
    AddLotFormComponent,
    LotListComponent,
    LotPageComponent,
    SidebarComponent,
    FooterComponent,
    ExtraContentComponent,
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

