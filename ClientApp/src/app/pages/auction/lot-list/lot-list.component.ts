import { Component, OnInit, Input, OnChanges } from '@angular/core';
import { Lot } from 'src/app/shared/lot.model';

@Component({
  selector: 'app-lot-list',
  templateUrl: './lot-list.component.html',
  styleUrls: ['./lot-list.component.scss']
})
export class LotListComponent implements OnInit, OnChanges {
  @Input() lots: [];
  pagesCount: number = 1;
  pageNow: number = 1;
  lotsOnPageCount: number = 3;
  lotsOnPage: Lot[] = [];
  constructor() { }

  pagination() {
    this.lotsOnPage = [];
    for (let i = 0; i < this.lotsOnPageCount; i++) {
      let curr = this.lotsOnPageCount * (this.pageNow - 1) + i;
      if (curr < this.lots.length) {
        this.lotsOnPage.push(this.lots[curr]);
      }
    }
  }

  pagesVsego() {
    this.pagesCount = Math.ceil(this.lots.length / this.lotsOnPageCount);
  }

  ngOnInit() {
    //console.log(this.lots);
  }

  ngOnChanges(): void {
    this.pageNow = 1;
    if (this.lots.length > 0) {
      this.pagesVsego();
      this.pagination();
    }
  }

}
