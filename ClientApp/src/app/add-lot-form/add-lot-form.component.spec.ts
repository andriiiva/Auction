import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddLotFormComponent } from './add-lot-form.component';

describe('AddLotFormComponent', () => {
  let component: AddLotFormComponent;
  let fixture: ComponentFixture<AddLotFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddLotFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddLotFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
