import { Component, Output, EventEmitter, OnChanges } from '@angular/core';
import { AuctionService } from 'src/app/auction.service';

@Component({
  selector: 'app-place-bet-form',
  templateUrl: './place-bet-form.component.html',
  styleUrls: ['./place-bet-form.component.scss']
})
export class PlaceBetFormComponent {
  price: number;
  userId: number;

  @Output() addBet = new EventEmitter();

  constructor(private AucSer: AuctionService) { }

  onSubmit(event) {
    this.addBet.emit(event);
    this.price = null;
    this.userId = null;
  }
}
