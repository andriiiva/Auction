import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PlaceBetFormComponent } from './place-bet-form.component';

describe('PlaceBetFormComponent', () => {
  let component: PlaceBetFormComponent;
  let fixture: ComponentFixture<PlaceBetFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PlaceBetFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PlaceBetFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
