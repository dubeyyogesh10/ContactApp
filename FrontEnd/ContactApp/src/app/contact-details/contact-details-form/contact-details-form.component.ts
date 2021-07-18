import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ContactDetail } from 'src/app/models/contact-detail.model';
import { ContactDetailService } from './../../service/contact-detail.service';

@Component({
  selector: 'app-contact-details-form',
  templateUrl: './contact-details-form.component.html',
  styleUrls: ['./contact-details-form.component.css'],
})
export class ContactDetailsFormComponent implements OnInit {
  constructor(
    public service: ContactDetailService,
    private toast: ToastrService
  ) {}

  ngOnInit(): void {}

  OnSubmit = (form: NgForm) => {
    if (this.service.formData.id === 0) {
      console.log('Add form');
      this.AddContact(form);
    } else {
      console.log('update form');
      this.UpdateContact(form);
    }
  };

  AddContact = (form: NgForm) => {
    this.service.postContactDetails().subscribe(
      (res) => {
        this.resetForm(form);
        this.service.getAllContactDetails();
        this.toast.success('Submitted SuccessFully', 'Contact Detailed Added');
      },
      (err) => {
        console.log('Error ' + err);
      }
    );
  };

  UpdateContact = (form: NgForm) => {
    this.service.UpdateContactDetails().subscribe(
      (res) => {
        this.resetForm(form);
        this.service.getAllContactDetails();
        this.toast.info('Updated SuccessFully', 'Contact Detailed Updated');
      },
      (err) => {
        console.log('Error ' + err);
      }
    );
  };

  resetForm = (form: NgForm) => {
    form.form.reset();
    this.service.formData = new ContactDetail();
  };
}
