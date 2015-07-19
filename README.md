NHibernate.AspNet.Identity.Multitenant
=======================

Simple multi-tenant solution.

## About this ##
This is a multi-tenant solution that uses as a based the popular [NHibernate.AspNet.Identity](https://github.com/nhibernate/NHibernate.AspNet.Identity) library.

## How it works ##
The way that the library has been extended to support multi-tenancy is by adding a new property to the IdentityUser that identifies to which tenant the user belongs to.

## Keep in mind ##
The reason why I call it a simple multi-tenant solution is because a single email address can only belong to a single tenant.
Many will agree and disagree that this is not a multi-tenant solution, however I think that this is at least the most simple solution to achieve multi-tenancy.
