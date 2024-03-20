public static void ChangeTracking(Repository<TestClass> repo)
{
    // Get the change tracker of the DbContext
    var changeTracker = repo.DbContext.ChangeTracker;

    // Iterate over the entries in the change tracker
    foreach (var entry in changeTracker.Entries())
    {
        // Get the entity and its state
        var entity = entry.Entity;
        var state = entry.State;

        // Perform some logic based on the state
        switch (state)
        {
            case EntityState.Added:
                // Do something when an entity is added
                break;
            case EntityState.Modified:
                // Do something when an entity is modified
                break;
            case EntityState.Deleted:
                // Do something when an entity is deleted
                break;
        }
    }
}
