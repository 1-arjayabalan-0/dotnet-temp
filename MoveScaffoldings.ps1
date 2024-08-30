# Define the source and destination directories
$sourceDir = ".\EMSCA.Infrastructure\Models"
$destinationDir = ".\EMSCA.Domain\Entities"

# Old and new namespace values
$oldNamespace = "EMSCA.Domain.Infrastructure.Data"
$newNamespace = "EMSCA.Domain.Entities"

# DbContextHelper file path
$dbContextHelperFile = ".\EMSCA.Infrastructure\Context\DbContextHelper.cs"

# Check if source and destination directories exist
if (-Not (Test-Path $sourceDir)) {
    Write-Host "Source directory does not exist: $sourceDir"
    exit 1
}

if (-Not (Test-Path $destinationDir)) {
    Write-Host "Destination directory does not exist: $destinationDir"
    exit 1
}

# Get all files in the source directory
$files = Get-ChildItem -Path $sourceDir -File

foreach ($file in $files) {
    $sourceFilePath = $file.FullName
    $destinationFilePath = Join-Path -Path $destinationDir -ChildPath $file.Name

    # Read the file content
    $content = Get-Content -Path $sourceFilePath

    # Replace the old namespace with the new one
    $updatedContent = $content -replace $oldNamespace, $newNamespace

    # Move the file and update the content
    Write-Host "Moving and updating $sourceFilePath"
    $updatedContent | Set-Content -Path $destinationFilePath

    # Remove the original file
    Remove-Item -Path $sourceFilePath
}

Write-Host "Files moved and namespaces updated successfully."

# Update the DbContextHelper file
if (Test-Path $dbContextHelperFile) {
    # Read the DbContextHelper file content
    $dbContextContent = Get-Content -Path $dbContextHelperFile -Raw

    # Remove the empty constructor
    $dbContextContent = $dbContextContent -replace 'public DbContextHelper\(\)\s*\{\s*\}', ''

    # Update class inheritance
    $dbContextContent = $dbContextContent -replace 'public partial class DbContextHelper\s*:\s*DbContext', 'public partial class DbContextHelper : EntityContextBase<DbContextHelper>'

    # Add the new `using` statements if they do not already exist
    $newUsings = @("using EMSCA.Domain.Entities;", "using EMSCA.Infrastructure.Data;")
    $usingPosition = $dbContextContent.IndexOf("namespace")

    foreach ($newUsing in $newUsings) {
        if ($dbContextContent -notmatch [regex]::Escape($newUsing)) {
            $dbContextContent = $dbContextContent.Insert($usingPosition - 2, "`n$newUsing")
        }
    }

    # Save the updated content
    $dbContextContent | Set-Content -Path $dbContextHelperFile

    Write-Host "DbContextHelper file updated successfully."
} else {
    Write-Host "DbContextHelper file does not exist: $dbContextHelperFile"
}

# # Define the source and destination directories
# $sourceDir = ".\EMSCA.Infrastructure\Models"
# $destinationDir = ".\EMSCA.Domain\Entities"

# # Old and new namespace values
# $oldNamespace = "EMSCA.Infrastructure.Data"
# $newNamespace = "EMSCA.Domain.Entities"

# # Check if source and destination directories exist
# if (-Not (Test-Path $sourceDir)) {
#     Write-Host "Source directory does not exist: $sourceDir"
#     exit 1
# }

# if (-Not (Test-Path $destinationDir)) {
#     Write-Host "Destination directory does not exist: $destinationDir"
#     exit 1
# }

# # Get all files in the source directory
# $files = Get-ChildItem -Path $sourceDir -File

# foreach ($file in $files) {
#     $sourceFilePath = $file.FullName
#     $destinationFilePath = Join-Path -Path $destinationDir -ChildPath $file.Name

#     # Read the file content
#     $content = Get-Content -Path $sourceFilePath

#     # Replace the old namespace with the new one
#     $updatedContent = $content -replace $oldNamespace, $newNamespace

#     # Move the file and update the content
#     Write-Host "Moving and updating $sourceFilePath"
#     $updatedContent | Set-Content -Path $destinationFilePath

#     # Remove the original file
#     Remove-Item -Path $sourceFilePath
# }

# Write-Host "Files moved and namespaces updated successfully."
